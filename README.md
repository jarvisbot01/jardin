# jardin

## Consultas

1. Devuelve un listado con todos los pagos que se realizaron en el año 2008 mediante Paypal Ordene el resultado de mayor a menor.

- Interfaz 
```csharp
Task<IEnumerable<Pago>> GetPaymentsOrderedIn2008();
```

- Método
```csharp
    public async Task<IEnumerable<Pago>> GetPaymentsOrderedIn2008()
    {
        var r = await _context
            .Pagos
            .Where(p => p.FechaPago.Year == 2008 && p.FormaPago.ToLower() == "paypal")
            .OrderBy(p => p.Total)
            .ToListAsync();
        return r;
    }
```
- Url Endpoint
```code
http://127.0.0.1:5000/api/Pago/GetPaymentsOrderedIn2008
```

2. Devuelve un listado que muestre solamente los clientes que no han realizado ningún pago.

- Interfaz 
```csharp
Task<IEnumerable<Cliente>> CustomersWhoHaveNotMadePayments();
```

- Método
```csharp
    public async Task<IEnumerable<Cliente>> CustomersWhoHaveNotMadePayments()
    {
        var r = await _context.Clientes.Where(c => c.Pagos.Count == 0).ToListAsync();
        return r;
    }
```
- Url Endpoint
```code
http://127.0.0.1:5000/api/Cliente/CustomersWhoHaveNotMadePayments
```