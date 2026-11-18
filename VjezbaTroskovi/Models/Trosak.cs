namespace VjezbaTroskovi.Models;

public class Trosak
{
    public int Id { get; set; }
    public string Opis { get; set; }
    public decimal Iznos { get; set; }
    public string? Kategorija { get; set; }
    public DateTime? DatumTroska { get; set; }
    public DateTime DatumKreiranja { get; }
}