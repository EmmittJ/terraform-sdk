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
    public TerraformProperty<string>? DataType
    {
        get => GetProperty<TerraformProperty<string>>("data_type");
        set => this.WithProperty("data_type", value);
    }

    /// <summary>
    /// The description of the user flow attribute that is shown to the user at the time of sign-up
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The display name of the user flow attribute.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The type of the user flow attribute
    /// </summary>
    public TerraformExpression AttributeType => this["attribute_type"];

}
