using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_signer_signing_job resource.
/// </summary>
public class AwsSignerSigningJob : TerraformResource
{
    public AwsSignerSigningJob(string name) : base("aws_signer_signing_job", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("completed_at");
        this.DeclareOutput("created_at");
        this.DeclareOutput("job_id");
        this.DeclareOutput("job_invoker");
        this.DeclareOutput("job_owner");
        this.DeclareOutput("platform_display_name");
        this.DeclareOutput("platform_id");
        this.DeclareOutput("profile_version");
        this.DeclareOutput("requested_by");
        this.DeclareOutput("revocation_record");
        this.DeclareOutput("signature_expires_at");
        this.DeclareOutput("signed_object");
        this.DeclareOutput("status");
        this.DeclareOutput("status_reason");
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
    /// The ignore_signing_job_failure attribute.
    /// </summary>
    public bool? IgnoreSigningJobFailure
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ignore_signing_job_failure")?.Value;
        set => this.WithProperty("ignore_signing_job_failure", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The profile_name attribute.
    /// </summary>
    public string? ProfileName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("profile_name")?.Value;
        set => this.WithProperty("profile_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The completed_at attribute.
    /// </summary>
    public TerraformExpression CompletedAt => this["completed_at"];

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The job_id attribute.
    /// </summary>
    public TerraformExpression JobId => this["job_id"];

    /// <summary>
    /// The job_invoker attribute.
    /// </summary>
    public TerraformExpression JobInvoker => this["job_invoker"];

    /// <summary>
    /// The job_owner attribute.
    /// </summary>
    public TerraformExpression JobOwner => this["job_owner"];

    /// <summary>
    /// The platform_display_name attribute.
    /// </summary>
    public TerraformExpression PlatformDisplayName => this["platform_display_name"];

    /// <summary>
    /// The platform_id attribute.
    /// </summary>
    public TerraformExpression PlatformId => this["platform_id"];

    /// <summary>
    /// The profile_version attribute.
    /// </summary>
    public TerraformExpression ProfileVersion => this["profile_version"];

    /// <summary>
    /// The requested_by attribute.
    /// </summary>
    public TerraformExpression RequestedBy => this["requested_by"];

    /// <summary>
    /// The revocation_record attribute.
    /// </summary>
    public TerraformExpression RevocationRecord => this["revocation_record"];

    /// <summary>
    /// The signature_expires_at attribute.
    /// </summary>
    public TerraformExpression SignatureExpiresAt => this["signature_expires_at"];

    /// <summary>
    /// The signed_object attribute.
    /// </summary>
    public TerraformExpression SignedObject => this["signed_object"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The status_reason attribute.
    /// </summary>
    public TerraformExpression StatusReason => this["status_reason"];

}
