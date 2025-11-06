using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Manages a azuread_user_flow_attribute resource.
/// </summary>
public class AzureadUserFlowAttribute : TerraformResource
{
    public AzureadUserFlowAttribute(string name) : base("azuread_user_flow_attribute", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("attribute_type");
    }

    /// <summary>
    /// The data type of the user flow attribute
    /// </summary>
    public string? DataType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_type")?.Value;
        set => this.WithProperty("data_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description of the user flow attribute that is shown to the user at the time of sign-up
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The display name of the user flow attribute.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The type of the user flow attribute
    /// </summary>
    public TerraformExpression AttributeType => this["attribute_type"];

}
