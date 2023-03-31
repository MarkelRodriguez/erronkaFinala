package dambi.rest_api.model;

import java.sql.Date;

import javax.persistence.Column;
import javax.persistence.ConstraintMode;
import javax.persistence.Entity;
import javax.persistence.ForeignKey;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.Table;

import com.fasterxml.jackson.annotation.JsonIdentityInfo;
import com.fasterxml.jackson.annotation.JsonIdentityReference;
import com.fasterxml.jackson.annotation.ObjectIdGenerators;

@Entity(name = "partida")
@Table(name = "partida")
public class Partida {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private int id;

    //bi taulak erlazionatu eta foreign key-a sortu 
    @JsonIdentityInfo(generator = ObjectIdGenerators.PropertyGenerator.class, property = "erabiltzailea")
	@JsonIdentityReference(alwaysAsId = true)
    @ManyToOne
    @JoinColumn(name = "erabiltzailea", referencedColumnName = "erabiltzailea", foreignKey = @ForeignKey(
        name = "fk_partida",
        foreignKeyDefinition = "FOREIGN KEY (erabiltzailea)\r\n" +
        "REFERENCES public.\"erabiltzailea\"(erabiltzailea) MATCH SIMPLE\r\n" +
        "ON UPDATE CASCADE\r\n" + 
        "ON DELETE CASCADE",
        value = ConstraintMode.CONSTRAINT
    ))
    private Erabiltzailea erabiltzailea;

    @Column(name = "puntuazioa")
    private int puntuazioa;

    @Column(name = "data")
    private Date data;

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public Erabiltzailea getErabiltzailea() {
        return erabiltzailea;
    }

    public void setErabiltzailea(Erabiltzailea erabiltzailea) {
        this.erabiltzailea = erabiltzailea;
    }

    public int getPuntuazioa() {
        return puntuazioa;
    }

    public void setPuntuazioa(int puntuazioa) {
        this.puntuazioa = puntuazioa;
    }

    public Date getData() {
        return data;
    }

    public void setData(Date data) {
        this.data = data;
    }

    
}
