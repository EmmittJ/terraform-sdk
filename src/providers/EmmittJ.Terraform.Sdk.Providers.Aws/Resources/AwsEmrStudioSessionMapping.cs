using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_emr_studio_session_mapping resource.
/// </summary>
public class AwsEmrStudioSessionMapping : TerraformResource
{
    public AwsEmrStudioSessionMapping(string name) : base("aws_emr_studio_session_mapping", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("identity_id");
        SetOutput("identity_name");
        SetOutput("identity_type");
        SetOutput("region");
        SetOutput("session_policy_arn");
        SetOutput("studio_id");
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
    /// The identity_id attribute.
    /// </summary>
    public TerraformProperty<string> IdentityId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("identity_id");
        set => SetProperty("identity_id", value);
    }

    /// <summary>
    /// The identity_name attribute.
    /// </summary>
    public TerraformProperty<string> IdentityName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("identity_name");
        set => SetProperty("identity_name", value);
    }

    /// <summary>
    /// The identity_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityType is required")]
    public required TerraformProperty<string> IdentityType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("identity_type");
        set => SetProperty("identity_type", value);
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
    /// The session_policy_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SessionPolicyArn is required")]
    public required TerraformProperty<string> SessionPolicyArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("session_policy_arn");
        set => SetProperty("session_policy_arn", value);
    }

    /// <summary>
    /// The studio_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StudioId is required")]
    public required TerraformProperty<string> StudioId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("studio_id");
        set => SetProperty("studio_id", value);
    }

}
