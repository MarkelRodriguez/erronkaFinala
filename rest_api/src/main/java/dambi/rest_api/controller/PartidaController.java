package dambi.rest_api.controller;

import java.sql.Date;
import java.time.LocalDate;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.ResponseBody;
import org.springframework.web.bind.annotation.RestController;

import dambi.rest_api.model.Erabiltzailea;
import dambi.rest_api.model.Partida;
import dambi.rest_api.repository.PartidaRepository;
import dambi.rest_api.services.PartidaService;

@RestController
@RequestMapping(path = "/api")
public class PartidaController {
    
    @Autowired
    private PartidaService partidaService;

    @GetMapping(path = "/allPartidak")
    public @ResponseBody Iterable<Partida> readPartidak(){
        return partidaService.getAllPartidak();
    }
    @PostMapping(path = "/addPartida") // Map ONLY POST Requests
    public @ResponseBody void addNewPartida(@RequestParam String emaila,
            @RequestParam String izena,
            @RequestParam String erabiltzailea,
            @RequestParam Date jaiotza_data,
            @RequestParam String abizena,
            @RequestParam String pasahitza,
            @RequestParam int puntuazioa
           ) {
        
        Date data = Date.valueOf(LocalDate.now());
        Erabiltzailea e = new Erabiltzailea();
        e.setIzena(izena);
        e.setAbizena(abizena);
        e.setErabiltzailea(erabiltzailea);
        e.setEmaila(emaila);
        e.setPasahitza(pasahitza);
        e.setJaiotza_data(jaiotza_data);
        
        Partida partida = new Partida();
        partida.setErabiltzailea(e);
        partida.setPuntuazioa(puntuazioa);
        partida.setData(data);
        partidaService.savePartida(partida);
    }

}
