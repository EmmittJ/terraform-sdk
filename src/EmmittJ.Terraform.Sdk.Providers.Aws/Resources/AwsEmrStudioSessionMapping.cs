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
    /// The identity_id attribute.
    /// </summary>
    public TerraformProperty<string>? IdentityId
    {
        get => GetProperty<TerraformProperty<string>>("identity_id");
        set => this.WithProperty("identity_id", value);
    }

    /// <summary>
    /// The identity_name attribute.
    /// </summary>
    public TerraformProperty<string>? IdentityName
    {
        get => GetProperty<TerraformProperty<string>>("identity_name");
        set => this.WithProperty("identity_name", value);
    }

    /// <summary>
    /// The identity_type attribute.
    /// </summary>
    public TerraformProperty<string>? IdentityType
    {
        get => GetProperty<TerraformProperty<string>>("identity_type");
        set => this.WithProperty("identity_type", value);
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
    /// The session_policy_arn attribute.
    /// </summary>
    public TerraformProperty<string>? SessionPolicyArn
    {
        get => GetProperty<TerraformProperty<string>>("session_policy_arn");
        set => this.WithProperty("session_policy_arn", value);
    }

    /// <summary>
    /// The studio_id attribute.
    /// </summary>
    public TerraformProperty<string>? StudioId
    {
        get => GetProperty<TerraformProperty<string>>("studio_id");
        set => this.WithProperty("studio_id", value);
    }

}
