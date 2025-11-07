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
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The identity_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IdentityId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("identity_id");
        set => this.WithProperty("identity_id", value);
    }

    /// <summary>
    /// The identity_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IdentityName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("identity_name");
        set => this.WithProperty("identity_name", value);
    }

    /// <summary>
    /// The identity_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IdentityType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("identity_type");
        set => this.WithProperty("identity_type", value);
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
    /// The session_policy_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SessionPolicyArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("session_policy_arn");
        set => this.WithProperty("session_policy_arn", value);
    }

    /// <summary>
    /// The studio_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StudioId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("studio_id");
        set => this.WithProperty("studio_id", value);
    }

}
