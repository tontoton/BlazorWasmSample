namespace BlazorWasmSample;
using System.ComponentModel.DataAnnotations;

public class GasMileageItem
{
    /// <summary>
    /// オドメータ（総走行距離）
    /// </summary>
    [Required]
    public double Odometer { get; set; }

    public string GetOdometerString()
    {
        // return $"{Odometer:#,0:F1}";
        return $"{Odometer:n1} km";
    }
    
    /// <summary>
    /// 走行距離
    /// </summary>
    public double Mileage { get; set; }

    public string GetMileageString()
    {
        return $"{Mileage:n1} km";
    }
    
    /// <summary>
    /// 給油量
    /// </summary>
    [Required]
    public double OilingQuantity { get; set; }

    public string GetOilingQuantityString()
    {
        return $"{OilingQuantity:n2} L";
    }
    
    /// <summary>
    /// 燃費
    /// </summary>
    public double GasMileage { get; set; }

    public string getGasMileageString()
    {
        return $"{GasMileage:n2} km/L";
    }
}