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
        SetOutput("result");
        SetOutput("function_name");
        SetOutput("id");
        SetOutput("input");
        SetOutput("lifecycle_scope");
        SetOutput("qualifier");
        SetOutput("region");
        SetOutput("terraform_key");
        SetOutput("triggers");
    }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionName is required")]
    public required TerraformProperty<string> FunctionName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("function_name");
        set => SetProperty("function_name", value);
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
    /// The input attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Input is required")]
    public required TerraformProperty<string> Input
    {
        get => GetRequiredOutput<TerraformProperty<string>>("input");
        set => SetProperty("input", value);
    }

    /// <summary>
    /// The lifecycle_scope attribute.
    /// </summary>
    public TerraformProperty<string> LifecycleScope
    {
        get => GetRequiredOutput<TerraformProperty<string>>("lifecycle_scope");
        set => SetProperty("lifecycle_scope", value);
    }

    /// <summary>
    /// The qualifier attribute.
    /// </summary>
    public TerraformProperty<string> Qualifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("qualifier");
        set => SetProperty("qualifier", value);
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
    /// The terraform_key attribute.
    /// </summary>
    public TerraformProperty<string> TerraformKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("terraform_key");
        set => SetProperty("terraform_key", value);
    }

    /// <summary>
    /// The triggers attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Triggers
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("triggers");
        set => SetProperty("triggers", value);
    }

    /// <summary>
    /// The result attribute.
    /// </summary>
    public TerraformExpression Result => this["result"];

}
