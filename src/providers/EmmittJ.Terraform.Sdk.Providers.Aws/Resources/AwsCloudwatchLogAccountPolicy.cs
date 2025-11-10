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
        SetOutput("id");
        SetOutput("policy_document");
        SetOutput("policy_name");
        SetOutput("policy_type");
        SetOutput("region");
        SetOutput("scope");
        SetOutput("selection_criteria");
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
    /// The policy_document attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyDocument is required")]
    public required TerraformProperty<string> PolicyDocument
    {
        get => GetRequiredOutput<TerraformProperty<string>>("policy_document");
        set => SetProperty("policy_document", value);
    }

    /// <summary>
    /// The policy_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyName is required")]
    public required TerraformProperty<string> PolicyName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("policy_name");
        set => SetProperty("policy_name", value);
    }

    /// <summary>
    /// The policy_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyType is required")]
    public required TerraformProperty<string> PolicyType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("policy_type");
        set => SetProperty("policy_type", value);
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
    /// The scope attribute.
    /// </summary>
    public TerraformProperty<string> Scope
    {
        get => GetRequiredOutput<TerraformProperty<string>>("scope");
        set => SetProperty("scope", value);
    }

    /// <summary>
    /// The selection_criteria attribute.
    /// </summary>
    public TerraformProperty<string> SelectionCriteria
    {
        get => GetRequiredOutput<TerraformProperty<string>>("selection_criteria");
        set => SetProperty("selection_criteria", value);
    }

}
