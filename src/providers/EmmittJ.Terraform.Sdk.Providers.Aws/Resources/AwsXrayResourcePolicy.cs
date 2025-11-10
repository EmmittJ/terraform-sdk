using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_xray_resource_policy resource.
/// </summary>
public class AwsXrayResourcePolicy : TerraformResource
{
    public AwsXrayResourcePolicy(string name) : base("aws_xray_resource_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("last_updated_time");
        SetOutput("bypass_policy_lockout_check");
        SetOutput("policy_document");
        SetOutput("policy_name");
        SetOutput("policy_revision_id");
        SetOutput("region");
    }

    /// <summary>
    /// The bypass_policy_lockout_check attribute.
    /// </summary>
    public TerraformProperty<bool> BypassPolicyLockoutCheck
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("bypass_policy_lockout_check");
        set => SetProperty("bypass_policy_lockout_check", value);
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
    /// The policy_revision_id attribute.
    /// </summary>
    public TerraformProperty<string> PolicyRevisionId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("policy_revision_id");
        set => SetProperty("policy_revision_id", value);
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
    /// The last_updated_time attribute.
    /// </summary>
    public TerraformExpression LastUpdatedTime => this["last_updated_time"];

}
