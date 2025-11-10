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
        SetOutput("arn");
        SetOutput("amount");
        SetOutput("breach_action");
        SetOutput("id");
        SetOutput("period");
        SetOutput("region");
        SetOutput("resource_arn");
        SetOutput("usage_type");
    }

    /// <summary>
    /// The amount attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Amount is required")]
    public required TerraformProperty<double> Amount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("amount");
        set => SetProperty("amount", value);
    }

    /// <summary>
    /// The breach_action attribute.
    /// </summary>
    public TerraformProperty<string> BreachAction
    {
        get => GetRequiredOutput<TerraformProperty<string>>("breach_action");
        set => SetProperty("breach_action", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The period attribute.
    /// </summary>
    public TerraformProperty<string> Period
    {
        get => GetRequiredOutput<TerraformProperty<string>>("period");
        set => SetProperty("period", value);
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
    /// The resource_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceArn is required")]
    public required TerraformProperty<string> ResourceArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_arn");
        set => SetProperty("resource_arn", value);
    }

    /// <summary>
    /// The usage_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UsageType is required")]
    public required TerraformProperty<string> UsageType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("usage_type");
        set => SetProperty("usage_type", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
