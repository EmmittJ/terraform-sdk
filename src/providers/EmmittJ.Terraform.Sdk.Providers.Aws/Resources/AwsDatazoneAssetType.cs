using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for forms_input in .
/// Nesting mode: set
/// </summary>
public class AwsDatazoneAssetTypeFormsInputBlock : TerraformBlock
{
    /// <summary>
    /// The map_block_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MapBlockKey is required")]
    public required TerraformProperty<string> MapBlockKey
    {
        set => SetProperty("map_block_key", value);
    }

    /// <summary>
    /// The required attribute.
    /// </summary>
    public TerraformProperty<bool>? Required
    {
        set => SetProperty("required", value);
    }

    /// <summary>
    /// The type_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TypeIdentifier is required")]
    public required TerraformProperty<string> TypeIdentifier
    {
        set => SetProperty("type_identifier", value);
    }

    /// <summary>
    /// The type_revision attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TypeRevision is required")]
    public required TerraformProperty<string> TypeRevision
    {
        set => SetProperty("type_revision", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDatazoneAssetTypeTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

}

/// <summary>
/// Manages a aws_datazone_asset_type resource.
/// </summary>
public class AwsDatazoneAssetType : TerraformResource
{
    public AwsDatazoneAssetType(string name) : base("aws_datazone_asset_type", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("created_at");
        SetOutput("created_by");
        SetOutput("revision");
        SetOutput("description");
        SetOutput("domain_identifier");
        SetOutput("name");
        SetOutput("owning_project_identifier");
        SetOutput("region");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The domain_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainIdentifier is required")]
    public required TerraformProperty<string> DomainIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain_identifier");
        set => SetProperty("domain_identifier", value);
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
    /// The owning_project_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OwningProjectIdentifier is required")]
    public required TerraformProperty<string> OwningProjectIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("owning_project_identifier");
        set => SetProperty("owning_project_identifier", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// Block for forms_input.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsDatazoneAssetTypeFormsInputBlock>? FormsInput
    {
        set => SetProperty("forms_input", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsDatazoneAssetTypeTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The created_by attribute.
    /// </summary>
    public TerraformExpression CreatedBy => this["created_by"];

    /// <summary>
    /// The revision attribute.
    /// </summary>
    public TerraformExpression Revision => this["revision"];

}
