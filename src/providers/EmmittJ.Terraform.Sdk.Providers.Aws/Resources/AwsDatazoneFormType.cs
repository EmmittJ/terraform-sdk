using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for model in AwsDatazoneFormType.
/// Nesting mode: list
/// </summary>
public class AwsDatazoneFormTypeModelBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "model";

    /// <summary>
    /// The smithy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Smithy is required")]
    public required TerraformValue<string> Smithy
    {
        get => new TerraformReference<string>(this, "smithy");
        set => SetArgument("smithy", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsDatazoneFormType.
/// Nesting mode: single
/// </summary>
public class AwsDatazoneFormTypeTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

}


/// <summary>
/// Represents a aws_datazone_form_type Terraform resource.
/// Manages a aws_datazone_form_type resource.
/// </summary>
public partial class AwsDatazoneFormType(string name) : TerraformResource("aws_datazone_form_type", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The domain_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainIdentifier is required")]
    public required TerraformValue<string> DomainIdentifier
    {
        get => new TerraformReference<string>(this, "domain_identifier");
        set => SetArgument("domain_identifier", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The owning_project_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OwningProjectIdentifier is required")]
    public required TerraformValue<string> OwningProjectIdentifier
    {
        get => new TerraformReference<string>(this, "owning_project_identifier");
        set => SetArgument("owning_project_identifier", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
    {
        get => new TerraformReference<string>(this, "created_at");
    }

    /// <summary>
    /// The created_by attribute.
    /// </summary>
    public TerraformValue<string> CreatedBy
    {
        get => new TerraformReference<string>(this, "created_by");
    }

    /// <summary>
    /// The imports attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Imports
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "imports").ResolveNodes(ctx));
    }

    /// <summary>
    /// The origin_domain_id attribute.
    /// </summary>
    public TerraformValue<string> OriginDomainId
    {
        get => new TerraformReference<string>(this, "origin_domain_id");
    }

    /// <summary>
    /// The origin_project_id attribute.
    /// </summary>
    public TerraformValue<string> OriginProjectId
    {
        get => new TerraformReference<string>(this, "origin_project_id");
    }

    /// <summary>
    /// The revision attribute.
    /// </summary>
    public TerraformValue<string> Revision
    {
        get => new TerraformReference<string>(this, "revision");
    }

    /// <summary>
    /// Model block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsDatazoneFormTypeModelBlock>? Model
    {
        get => GetArgument<TerraformList<AwsDatazoneFormTypeModelBlock>>("model");
        set => SetArgument("model", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsDatazoneFormTypeTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsDatazoneFormTypeTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
