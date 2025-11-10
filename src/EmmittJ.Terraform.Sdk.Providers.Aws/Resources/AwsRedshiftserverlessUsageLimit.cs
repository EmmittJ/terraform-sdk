using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_redshiftserverless_usage_limit resource.
/// </summary>
public class AwsRedshiftserverlessUsageLimit : TerraformResource
{
    public AwsRedshiftserverlessUsageLimit(string name) : base("aws_redshiftserverless_usage_limit", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The amount attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Amount is required")]
    public required TerraformProperty<double> Amount
    {
        get => GetProperty<TerraformProperty<double>>("amount");
        set => this.WithProperty("amount", value);
    }

    /// <summary>
    /// The breach_action attribute.
    /// </summary>
    public TerraformProperty<string>? BreachAction
    {
        get => GetProperty<TerraformProperty<string>>("breach_action");
        set => this.WithProperty("breach_action", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The period attribute.
    /// </summary>
    public TerraformProperty<string>? Period
    {
        get => GetProperty<TerraformProperty<string>>("period");
        set => this.WithProperty("period", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceArn is required")]
    public required TerraformProperty<string> ResourceArn
    {
        get => GetProperty<TerraformProperty<string>>("resource_arn");
        set => this.WithProperty("resource_arn", value);
    }

    /// <summary>
    /// The usage_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UsageType is required")]
    public required TerraformProperty<string> UsageType
    {
        get => GetProperty<TerraformProperty<string>>("usage_type");
        set => this.WithProperty("usage_type", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
