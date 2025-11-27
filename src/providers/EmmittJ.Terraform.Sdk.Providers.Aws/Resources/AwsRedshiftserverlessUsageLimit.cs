using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_redshiftserverless_usage_limit Terraform resource.
/// Manages a aws_redshiftserverless_usage_limit resource.
/// </summary>
public partial class AwsRedshiftserverlessUsageLimit(string name) : TerraformResource("aws_redshiftserverless_usage_limit", name)
{
    /// <summary>
    /// The amount attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Amount is required")]
    public required TerraformValue<double> Amount
    {
        get => new TerraformReference<double>(this, "amount");
        set => SetArgument("amount", value);
    }

    /// <summary>
    /// The breach_action attribute.
    /// </summary>
    public TerraformValue<string>? BreachAction
    {
        get => new TerraformReference<string>(this, "breach_action");
        set => SetArgument("breach_action", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The period attribute.
    /// </summary>
    public TerraformValue<string>? Period
    {
        get => new TerraformReference<string>(this, "period");
        set => SetArgument("period", value);
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
    /// The resource_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceArn is required")]
    public required TerraformValue<string> ResourceArn
    {
        get => new TerraformReference<string>(this, "resource_arn");
        set => SetArgument("resource_arn", value);
    }

    /// <summary>
    /// The usage_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UsageType is required")]
    public required TerraformValue<string> UsageType
    {
        get => new TerraformReference<string>(this, "usage_type");
        set => SetArgument("usage_type", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

}
