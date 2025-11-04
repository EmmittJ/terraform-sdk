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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The identity_id attribute.
    /// </summary>
    public string? IdentityId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("identity_id")?.Value;
        set => this.WithProperty("identity_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The identity_name attribute.
    /// </summary>
    public string? IdentityName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("identity_name")?.Value;
        set => this.WithProperty("identity_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The identity_type attribute.
    /// </summary>
    public string? IdentityType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("identity_type")?.Value;
        set => this.WithProperty("identity_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The session_policy_arn attribute.
    /// </summary>
    public string? SessionPolicyArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("session_policy_arn")?.Value;
        set => this.WithProperty("session_policy_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The studio_id attribute.
    /// </summary>
    public string? StudioId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("studio_id")?.Value;
        set => this.WithProperty("studio_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
