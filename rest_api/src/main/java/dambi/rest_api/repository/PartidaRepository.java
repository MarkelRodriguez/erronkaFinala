package dambi.rest_api.repository;

import org.springframework.data.repository.CrudRepository;

import dambi.rest_api.model.Partida;

public interface PartidaRepository extends CrudRepository<Partida, Integer> {
    
}
