using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ses_configuration_set resource.
/// </summary>
public class AwsSesConfigurationSet : TerraformResource
{
    public AwsSesConfigurationSet(string name) : base("aws_ses_configuration_set", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("last_fresh_start");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The reputation_metrics_enabled attribute.
    /// </summary>
    public bool? ReputationMetricsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("reputation_metrics_enabled")?.Value;
        set => this.WithProperty("reputation_metrics_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The sending_enabled attribute.
    /// </summary>
    public bool? SendingEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("sending_enabled")?.Value;
        set => this.WithProperty("sending_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The last_fresh_start attribute.
    /// </summary>
    public TerraformExpression LastFreshStart => this["last_fresh_start"];

}
