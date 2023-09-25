namespace SnackerUI.Models;

public record Snack(
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    Uri Image,
    List<string> Savoury,
    List<string> Sweet);
