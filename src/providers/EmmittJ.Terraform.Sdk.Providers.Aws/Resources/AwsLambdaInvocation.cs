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
        this.WithOutput("result");
    }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionName is required")]
    public required TerraformProperty<string> FunctionName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("function_name");
        set => this.WithProperty("function_name", value);
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
    /// The input attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Input is required")]
    public required TerraformProperty<string> Input
    {
        get => GetRequiredProperty<TerraformProperty<string>>("input");
        set => this.WithProperty("input", value);
    }

    /// <summary>
    /// The lifecycle_scope attribute.
    /// </summary>
    public TerraformProperty<string>? LifecycleScope
    {
        get => GetProperty<TerraformProperty<string>>("lifecycle_scope");
        set => this.WithProperty("lifecycle_scope", value);
    }

    /// <summary>
    /// The qualifier attribute.
    /// </summary>
    public TerraformProperty<string>? Qualifier
    {
        get => GetProperty<TerraformProperty<string>>("qualifier");
        set => this.WithProperty("qualifier", value);
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
    /// The terraform_key attribute.
    /// </summary>
    public TerraformProperty<string>? TerraformKey
    {
        get => GetProperty<TerraformProperty<string>>("terraform_key");
        set => this.WithProperty("terraform_key", value);
    }

    /// <summary>
    /// The triggers attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Triggers
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("triggers");
        set => this.WithProperty("triggers", value);
    }

    /// <summary>
    /// The result attribute.
    /// </summary>
    public TerraformExpression Result => this["result"];

}
