using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Retrieves information about a azuread_directory_object.
/// </summary>
public class AzureadDirectoryObjectDataSource : TerraformDataSource
{
    public AzureadDirectoryObjectDataSource(string name) : base("azuread_directory_object", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("type");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The object ID of the Directory Object
    /// </summary>
    public string? ObjectId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("object_id")?.Value;
        set => this.WithProperty("object_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The OData type of the Directory Object
    /// </summary>
    public TerraformExpression Type => this["type"];

}
