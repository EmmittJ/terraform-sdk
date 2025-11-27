using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsQuicksightAccountSettings.
/// Nesting mode: single
/// </summary>
public class AwsQuicksightAccountSettingsTimeoutsBlock : TerraformBlock
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
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_quicksight_account_settings Terraform resource.
/// Manages a aws_quicksight_account_settings resource.
/// </summary>
public partial class AwsQuicksightAccountSettings(string name) : TerraformResource("aws_quicksight_account_settings", name)
{
    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public TerraformValue<string> AwsAccountId
    {
        get => new TerraformReference<string>(this, "aws_account_id");
        set => SetArgument("aws_account_id", value);
    }

    /// <summary>
    /// The default_namespace attribute.
    /// </summary>
    public TerraformValue<string> DefaultNamespace
    {
        get => new TerraformReference<string>(this, "default_namespace");
        set => SetArgument("default_namespace", value);
    }

    /// <summary>
    /// The termination_protection_enabled attribute.
    /// </summary>
    public TerraformValue<bool> TerminationProtectionEnabled
    {
        get => new TerraformReference<bool>(this, "termination_protection_enabled");
        set => SetArgument("termination_protection_enabled", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsQuicksightAccountSettingsTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsQuicksightAccountSettingsTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
