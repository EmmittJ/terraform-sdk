using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_shield_subscription resource.
/// </summary>
public class AwsShieldSubscription : TerraformResource
{
    public AwsShieldSubscription(string name) : base("aws_shield_subscription", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("auto_renew");
        SetOutput("skip_destroy");
    }

    /// <summary>
    /// Whether to automatically renew the subscription when it expires.
    /// </summary>
    public TerraformProperty<string> AutoRenew
    {
        get => GetRequiredOutput<TerraformProperty<string>>("auto_renew");
        set => SetProperty("auto_renew", value);
    }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    public TerraformProperty<bool> SkipDestroy
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("skip_destroy");
        set => SetProperty("skip_destroy", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
