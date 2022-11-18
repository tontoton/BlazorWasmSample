namespace BlazorWasmSample;
using System.ComponentModel.DataAnnotations;

public class GasMileageItem
{
    /// <summary>
    /// オドメータ（総走行距離）
    /// </summary>
    [Required]
    public double Odometer { get; set; }
    
    /// <summary>
    /// 走行距離
    /// </summary>
    public double Mileage { get; set; }
    
    /// <summary>
    /// 給油量
    /// </summary>
    [Required]
    public double OilingQuantity { get; set; }
    
    /// <summary>
    /// 燃費
    /// </summary>
    public double GasMileage { get; set; }
}