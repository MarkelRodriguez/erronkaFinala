package dambi.rest_api.model;

import java.sql.Date;
import java.util.List;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.OneToMany;
import javax.persistence.Table;
import javax.persistence.FetchType;
import javax.persistence.CascadeType;
@Entity
@Table(name = "erabiltzailea")
public class Erabiltzailea {

    //datubaseko taularen eremuak sortu
    @Column(name = "id")
    private int id;
    
    @Column(name = "izena")
    private String izena;

    @Column(name = "abizena")
    private String abizena;

    //erabiltzailea eremua primary key izango da
    @Id
    @Column(name = "erabiltzailea")
    private String erabiltzailea;
    
    @Column(name = "emaila")
    private String emaila;
    
    @Column(name = "pasahitza")
    private String pasahitza;

    @Column(name = "jaiotza_data")
    private Date jaiotza_data;

    //bi taulak erlazionatu
    @OneToMany(mappedBy = "erabiltzailea", fetch = FetchType.LAZY, cascade = CascadeType.ALL)
    private List<Partida> partidak;

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getIzena() {
        return izena;
    }

    public void setIzena(String izena) {
        this.izena = izena;
    }

    public String getAbizena() {
        return abizena;
    }

    public void setAbizena(String abizena) {
        this.abizena = abizena;
    }

    public String getErabiltzailea() {
        return erabiltzailea;
    }

    public void setErabiltzailea(String erabiltzailea) {
        this.erabiltzailea = erabiltzailea;
    }

    public String getEmaila() {
        return emaila;
    }

    public void setEmaila(String emaila) {
        this.emaila = emaila;
    }

    public String getPasahitza() {
        return pasahitza;
    }

    public void setPasahitza(String pasahitza) {
        this.pasahitza = pasahitza;
    }

    public Date getJaiotza_data() {
        return jaiotza_data;
    }

    public void setJaiotza_data(Date jaiotza_data) {
        this.jaiotza_data = jaiotza_data;
    }

    public List<Partida> getPartidak() {
        return partidak;
    }

    public void setPartidak(List<Partida> partidak) {
        this.partidak = partidak;
    }

}
