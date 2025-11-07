using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lambda_invocation resource.
/// </summary>
public class AwsLambdaInvocation : TerraformResource
{
    public AwsLambdaInvocation(string name) : base("aws_lambda_invocation", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("result");
    }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? FunctionName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("function_name");
        set => this.WithProperty("function_name", value);
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
    /// The input attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Input
    {
        get => GetProperty<TerraformLiteralProperty<string>>("input");
        set => this.WithProperty("input", value);
    }

    /// <summary>
    /// The lifecycle_scope attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LifecycleScope
    {
        get => GetProperty<TerraformLiteralProperty<string>>("lifecycle_scope");
        set => this.WithProperty("lifecycle_scope", value);
    }

    /// <summary>
    /// The qualifier attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Qualifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("qualifier");
        set => this.WithProperty("qualifier", value);
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
    /// The terraform_key attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TerraformKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("terraform_key");
        set => this.WithProperty("terraform_key", value);
    }

    /// <summary>
    /// The triggers attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Triggers
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("triggers");
        set => this.WithProperty("triggers", value);
    }

    /// <summary>
    /// The result attribute.
    /// </summary>
    public TerraformExpression Result => this["result"];

}
