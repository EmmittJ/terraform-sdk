using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_auditmanager_framework_share resource.
/// </summary>
public class AwsAuditmanagerFrameworkShare : TerraformResource
{
    public AwsAuditmanagerFrameworkShare(string name) : base("aws_auditmanager_framework_share", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("id");
        this.DeclareOutput("status");
    }

    /// <summary>
    /// The comment attribute.
    /// </summary>
    public string? Comment
    {
        get => GetProperty<TerraformLiteralProperty<string>>("comment")?.Value;
        set => this.WithProperty("comment", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The destination_account attribute.
    /// </summary>
    public string? DestinationAccount
    {
        get => GetProperty<TerraformLiteralProperty<string>>("destination_account")?.Value;
        set => this.WithProperty("destination_account", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The destination_region attribute.
    /// </summary>
    public string? DestinationRegion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("destination_region")?.Value;
        set => this.WithProperty("destination_region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The framework_id attribute.
    /// </summary>
    public string? FrameworkId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("framework_id")?.Value;
        set => this.WithProperty("framework_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
