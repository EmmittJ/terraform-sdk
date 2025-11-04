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
        this.DeclareOutput("last_updated_time");
    }

    /// <summary>
    /// The bypass_policy_lockout_check attribute.
    /// </summary>
    public bool? BypassPolicyLockoutCheck
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("bypass_policy_lockout_check")?.Value;
        set => this.WithProperty("bypass_policy_lockout_check", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The policy_document attribute.
    /// </summary>
    public string? PolicyDocument
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_document")?.Value;
        set => this.WithProperty("policy_document", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The policy_name attribute.
    /// </summary>
    public string? PolicyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_name")?.Value;
        set => this.WithProperty("policy_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The policy_revision_id attribute.
    /// </summary>
    public string? PolicyRevisionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_revision_id")?.Value;
        set => this.WithProperty("policy_revision_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The last_updated_time attribute.
    /// </summary>
    public TerraformExpression LastUpdatedTime => this["last_updated_time"];

}
