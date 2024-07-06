using Person_identifier;

bool continuar = true;

while (continuar)
{
    Console.Clear();

    Console.WriteLine("Ingrese el nombre de la persona:");
    var nombrePersona = Console.ReadLine();
    if (nombrePersona != null && nombrePersona.Trim() != "")
    {
        var sampleData = new MLModel.ModelInput()
        {
            Person = nombrePersona,
        };

        var result = MLModel.Predict(sampleData);

        Console.WriteLine(result.PredictedLabel == 0 ? "Persona Humana" : "Persona Jurídica");
    }
    else
    {
        continue;
    }

    Console.WriteLine("¿Desea ingresar otra persona? (s/n)");
    var respuesta = Console.ReadLine();

    if (respuesta?.ToLower() != "s")
    {
        continuar = false;
    }
}