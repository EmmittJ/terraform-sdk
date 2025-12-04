using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsDatazoneUserProfile.
/// Nesting mode: single
/// </summary>
public class AwsDatazoneUserProfileTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_datazone_user_profile Terraform resource.
/// Manages a aws_datazone_user_profile resource.
/// </summary>
public partial class AwsDatazoneUserProfile(string name) : TerraformResource("aws_datazone_user_profile", name)
{
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => GetArgument<TerraformValue<string>>("status") ?? AsReference("status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// The user_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserIdentifier is required")]
    public required TerraformValue<string> UserIdentifier
    {
        get => GetRequiredArgument<TerraformValue<string>>("user_identifier");
        set => SetArgument("user_identifier", value);
    }

    /// <summary>
    /// The user_type attribute.
    /// </summary>
    public TerraformValue<string> UserType
    {
        get => GetArgument<TerraformValue<string>>("user_type") ?? AsReference("user_type");
        set => SetArgument("user_type", value);
    }

    /// <summary>
    /// The details attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Details
        => AsReference("details");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
        => AsReference("type");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsDatazoneUserProfileTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsDatazoneUserProfileTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
