using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej5.Domain;

public class VehiculoCombustible : Vehiculo
{
    private double kilometrosPorLitro;
    private double litrosExtra;

    public VehiculoCombustible(string patente, string marca, string modelo, int anio, double capacidadCarga,
                               Sucursal sucursal, double kilometrosPorLitro, double litrosExtra)
        : base(VehiculoTipo.Combustible, patente, marca, modelo, anio, capacidadCarga, sucursal)
    {
        this.kilometrosPorLitro = kilometrosPorLitro;
        this.litrosExtra = litrosExtra;
    }

    public double GetKilometrosPorLitro() => kilometrosPorLitro;
    public double GetLitrosExtra() => litrosExtra;

    public override double CalcularConsumo(double kilometros)
    {
        double total = kilometros / kilometrosPorLitro;
        if ((2026 - GetAnio()) > 5)
        {
            total = kilometros / kilometrosPorLitro + litrosExtra * (kilometros / 15);
        }
        return total;
    }
}