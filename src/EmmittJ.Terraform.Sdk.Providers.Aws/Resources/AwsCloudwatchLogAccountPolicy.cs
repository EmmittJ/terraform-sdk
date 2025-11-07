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
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The policy_document attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PolicyDocument
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_document");
        set => this.WithProperty("policy_document", value);
    }

    /// <summary>
    /// The policy_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PolicyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_name");
        set => this.WithProperty("policy_name", value);
    }

    /// <summary>
    /// The policy_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PolicyType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_type");
        set => this.WithProperty("policy_type", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Scope
    {
        get => GetProperty<TerraformLiteralProperty<string>>("scope");
        set => this.WithProperty("scope", value);
    }

    /// <summary>
    /// The selection_criteria attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SelectionCriteria
    {
        get => GetProperty<TerraformLiteralProperty<string>>("selection_criteria");
        set => this.WithProperty("selection_criteria", value);
    }

}
