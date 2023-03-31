package dambi.rest_api.controller;

import java.sql.Date;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.ResponseBody;
import org.springframework.web.bind.annotation.RestController;

import dambi.rest_api.model.Erabiltzailea;
import dambi.rest_api.repository.ErabiltzaileaRepository;
import dambi.rest_api.services.ErabiltzaileaService;

@RestController
@RequestMapping(path = "/api")
public class ErabiltzaileaController {
    @Autowired
    private ErabiltzaileaService erabiltzaileaService;

    // erabiltzaileak erakutsi
    @GetMapping(path = "/allErabiltzaileak")
    public @ResponseBody Iterable<Erabiltzailea> readErabiltzaileak(){
        return erabiltzaileaService.getAllErabiltzailea();
    }
    //erabiltzaile berria sartu
    @PostMapping(path = "/addErabiltzaileak")
    public @ResponseBody void addNewErabiltzailea(@RequestParam String izena,
            @RequestParam String abizena,
            @RequestParam String erabiltzailea,
            @RequestParam String emaila,
            @RequestParam String pasahitza,
            @RequestParam Date jaiotza_data){
        
        Erabiltzailea e = new Erabiltzailea();
        e.setIzena(izena);
        e.setAbizena(abizena);
        e.setErabiltzailea(erabiltzailea);
        e.setEmaila(emaila);
        e.setPasahitza(pasahitza);
        e.setJaiotza_data(jaiotza_data);  
        erabiltzaileaService.saveErabiltzailea(e);      
    }

    //aldatu erabiltzailea
    @PutMapping(path = "/updateErabiltzaileak{erabiltzailea}")
    public @ResponseBody Erabiltzailea updateErabiltzailea(@PathVariable String erabiltzailea, Erabiltzailea e){
        e.setErabiltzailea(erabiltzailea);
        return erabiltzaileaService.saveErabiltzailea(e);
    } 

    //erabiltzailea ezabatu
    @DeleteMapping(path = "/deleteErabiltazilea{erabiltzailea}")
    public ResponseEntity<Void> deleteUserById(@PathVariable String erabiltzailea){
        try{
            erabiltzaileaService.deleteErabiltazilea(erabiltzailea);
            return ResponseEntity.ok().build();
        }catch(Exception ex){
            System.out.println("Errorea" + erabiltzailea + "erabiltzailea ezabatzerakoan. ");
            return ResponseEntity.notFound().build();
        }

    }
    
    
}
