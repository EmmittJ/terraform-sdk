using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for single_sign_on in AwsDatazoneDomain.
/// Nesting mode: list
/// </summary>
public class AwsDatazoneDomainSingleSignOnBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "single_sign_on";

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The user_assignment attribute.
    /// </summary>
    public TerraformValue<string>? UserAssignment
    {
        get => new TerraformReference<string>(this, "user_assignment");
        set => SetArgument("user_assignment", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsDatazoneDomain.
/// Nesting mode: single
/// </summary>
public class AwsDatazoneDomainTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a aws_datazone_domain Terraform resource.
/// Manages a aws_datazone_domain resource.
/// </summary>
public partial class AwsDatazoneDomain(string name) : TerraformResource("aws_datazone_domain", name)
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
    /// The domain_execution_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainExecutionRole is required")]
    public required TerraformValue<string> DomainExecutionRole
    {
        get => new TerraformReference<string>(this, "domain_execution_role");
        set => SetArgument("domain_execution_role", value);
    }

    /// <summary>
    /// The domain_version attribute.
    /// </summary>
    public TerraformValue<string> DomainVersion
    {
        get => new TerraformReference<string>(this, "domain_version");
        set => SetArgument("domain_version", value);
    }

    /// <summary>
    /// The kms_key_identifier attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyIdentifier
    {
        get => new TerraformReference<string>(this, "kms_key_identifier");
        set => SetArgument("kms_key_identifier", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The service_role attribute.
    /// </summary>
    public TerraformValue<string>? ServiceRole
    {
        get => new TerraformReference<string>(this, "service_role");
        set => SetArgument("service_role", value);
    }

    /// <summary>
    /// The skip_deletion_check attribute.
    /// </summary>
    public TerraformValue<bool>? SkipDeletionCheck
    {
        get => new TerraformReference<bool>(this, "skip_deletion_check");
        set => SetArgument("skip_deletion_check", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The portal_url attribute.
    /// </summary>
    public TerraformValue<string> PortalUrl
    {
        get => new TerraformReference<string>(this, "portal_url");
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
    }

    /// <summary>
    /// SingleSignOn block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsDatazoneDomainSingleSignOnBlock>? SingleSignOn
    {
        get => GetArgument<TerraformList<AwsDatazoneDomainSingleSignOnBlock>>("single_sign_on");
        set => SetArgument("single_sign_on", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsDatazoneDomainTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsDatazoneDomainTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
