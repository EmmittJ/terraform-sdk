using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for forms_input in AwsDatazoneAssetType.
/// Nesting mode: set
/// </summary>
public class AwsDatazoneAssetTypeFormsInputBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "forms_input";

    /// <summary>
    /// The map_block_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MapBlockKey is required")]
    public required TerraformValue<string> MapBlockKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("map_block_key");
        set => SetArgument("map_block_key", value);
    }

    /// <summary>
    /// The required attribute.
    /// </summary>
    public TerraformValue<bool>? Required
    {
        get => GetArgument<TerraformValue<bool>>("required");
        set => SetArgument("required", value);
    }

    /// <summary>
    /// The type_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TypeIdentifier is required")]
    public required TerraformValue<string> TypeIdentifier
    {
        get => GetRequiredArgument<TerraformValue<string>>("type_identifier");
        set => SetArgument("type_identifier", value);
    }

    /// <summary>
    /// The type_revision attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TypeRevision is required")]
    public required TerraformValue<string> TypeRevision
    {
        get => GetRequiredArgument<TerraformValue<string>>("type_revision");
        set => SetArgument("type_revision", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsDatazoneAssetType.
/// Nesting mode: single
/// </summary>
public class AwsDatazoneAssetTypeTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

}


/// <summary>
/// Represents a aws_datazone_asset_type Terraform resource.
/// Manages a aws_datazone_asset_type resource.
/// </summary>
public partial class AwsDatazoneAssetType(string name) : TerraformResource("aws_datazone_asset_type", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The domain_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainIdentifier is required")]
    public required TerraformValue<string> DomainIdentifier
    {
        get => GetRequiredArgument<TerraformValue<string>>("domain_identifier");
        set => SetArgument("domain_identifier", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The owning_project_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OwningProjectIdentifier is required")]
    public required TerraformValue<string> OwningProjectIdentifier
    {
        get => GetRequiredArgument<TerraformValue<string>>("owning_project_identifier");
        set => SetArgument("owning_project_identifier", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
        => AsReference("created_at");

    /// <summary>
    /// The created_by attribute.
    /// </summary>
    public TerraformValue<string> CreatedBy
        => AsReference("created_by");

    /// <summary>
    /// The revision attribute.
    /// </summary>
    public TerraformValue<string> Revision
        => AsReference("revision");

    /// <summary>
    /// FormsInput block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsDatazoneAssetTypeFormsInputBlock>? FormsInput
    {
        get => GetArgument<TerraformSet<AwsDatazoneAssetTypeFormsInputBlock>>("forms_input");
        set => SetArgument("forms_input", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsDatazoneAssetTypeTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsDatazoneAssetTypeTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
