using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_organizations_policy_attachment resource.
/// </summary>
public class AwsOrganizationsPolicyAttachment : TerraformResource
{
    public AwsOrganizationsPolicyAttachment(string name) : base("aws_organizations_policy_attachment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("policy_id");
        SetOutput("skip_destroy");
        SetOutput("target_id");
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
    /// The policy_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyId is required")]
    public required TerraformProperty<string> PolicyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("policy_id");
        set => SetProperty("policy_id", value);
    }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    public TerraformProperty<bool> SkipDestroy
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("skip_destroy");
        set => SetProperty("skip_destroy", value);
    }

    /// <summary>
    /// The target_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetId is required")]
    public required TerraformProperty<string> TargetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_id");
        set => SetProperty("target_id", value);
    }

}
