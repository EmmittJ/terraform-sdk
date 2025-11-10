using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermEventhubNamespaceSchemaGroupTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Manages a azurerm_eventhub_namespace_schema_group resource.
/// </summary>
public class AzurermEventhubNamespaceSchemaGroup : TerraformResource
{
    public AzurermEventhubNamespaceSchemaGroup(string name) : base("azurerm_eventhub_namespace_schema_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("name");
        SetOutput("namespace_id");
        SetOutput("schema_compatibility");
        SetOutput("schema_type");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The namespace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceId is required")]
    public required TerraformProperty<string> NamespaceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("namespace_id");
        set => SetProperty("namespace_id", value);
    }

    /// <summary>
    /// The schema_compatibility attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SchemaCompatibility is required")]
    public required TerraformProperty<string> SchemaCompatibility
    {
        get => GetRequiredOutput<TerraformProperty<string>>("schema_compatibility");
        set => SetProperty("schema_compatibility", value);
    }

    /// <summary>
    /// The schema_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SchemaType is required")]
    public required TerraformProperty<string> SchemaType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("schema_type");
        set => SetProperty("schema_type", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermEventhubNamespaceSchemaGroupTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
