package dambi.rest_api.services;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import dambi.rest_api.model.Erabiltzailea;
import dambi.rest_api.repository.ErabiltzaileaRepository;

@Service
public class ErabiltzaileaService {
    @Autowired // This means to get the bean called userRepository
    // Which is auto-generated by Spring, we will use it to handle the data
    private ErabiltzaileaRepository erabiltzileaRepository;

    public Erabiltzailea saveErabiltzailea(Erabiltzailea erabiltzailea) {
        return erabiltzileaRepository.save(erabiltzailea);
    }

    public Iterable<Erabiltzailea> getAllErabiltzailea() {
        // This returns a JSON or XML with the users
        return erabiltzileaRepository.findAll();
    }

    public void deleteErabiltazilea(String erabiltzailea) {
        erabiltzileaRepository.deleteById(erabiltzailea);
    }
}
