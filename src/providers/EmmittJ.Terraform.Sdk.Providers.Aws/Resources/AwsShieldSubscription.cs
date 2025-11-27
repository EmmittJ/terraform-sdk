using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_shield_subscription Terraform resource.
/// Manages a aws_shield_subscription resource.
/// </summary>
public partial class AwsShieldSubscription(string name) : TerraformResource("aws_shield_subscription", name)
{
    /// <summary>
    /// Whether to automatically renew the subscription when it expires.
    /// </summary>
    public TerraformValue<string> AutoRenew
    {
        get => new TerraformReference<string>(this, "auto_renew");
        set => SetArgument("auto_renew", value);
    }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    public TerraformValue<bool>? SkipDestroy
    {
        get => new TerraformReference<bool>(this, "skip_destroy");
        set => SetArgument("skip_destroy", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

}
