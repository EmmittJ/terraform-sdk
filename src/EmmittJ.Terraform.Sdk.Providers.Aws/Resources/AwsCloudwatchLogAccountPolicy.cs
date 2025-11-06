using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudwatch_log_account_policy resource.
/// </summary>
public class AwsCloudwatchLogAccountPolicy : TerraformResource
{
    public AwsCloudwatchLogAccountPolicy(string name) : base("aws_cloudwatch_log_account_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The policy_document attribute.
    /// </summary>
    public string? PolicyDocument
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_document")?.Value;
        set => this.WithProperty("policy_document", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The policy_name attribute.
    /// </summary>
    public string? PolicyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_name")?.Value;
        set => this.WithProperty("policy_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The policy_type attribute.
    /// </summary>
    public string? PolicyType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_type")?.Value;
        set => this.WithProperty("policy_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public string? Scope
    {
        get => GetProperty<TerraformLiteralProperty<string>>("scope")?.Value;
        set => this.WithProperty("scope", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The selection_criteria attribute.
    /// </summary>
    public string? SelectionCriteria
    {
        get => GetProperty<TerraformLiteralProperty<string>>("selection_criteria")?.Value;
        set => this.WithProperty("selection_criteria", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
