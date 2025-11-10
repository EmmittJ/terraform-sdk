using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadUserFlowAttributeTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataType is required")]
    public required TerraformProperty<string> DataType
    {
        get => GetProperty<TerraformProperty<string>>("data_type");
        set => this.WithProperty("data_type", value);
    }

    /// <summary>
    /// The description of the user flow attribute that is shown to the user at the time of sign-up
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    public required TerraformProperty<string> Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The display name of the user flow attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadUserFlowAttributeTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzureadUserFlowAttributeTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The type of the user flow attribute
    /// </summary>
    public TerraformExpression AttributeType => this["attribute_type"];

}
