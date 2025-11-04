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
    /// The policy_id attribute.
    /// </summary>
    public string? PolicyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_id")?.Value;
        set => this.WithProperty("policy_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    public bool? SkipDestroy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("skip_destroy")?.Value;
        set => this.WithProperty("skip_destroy", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The target_id attribute.
    /// </summary>
    public string? TargetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_id")?.Value;
        set => this.WithProperty("target_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
