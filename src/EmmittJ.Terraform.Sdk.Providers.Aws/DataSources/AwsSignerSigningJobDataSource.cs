using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_signer_signing_job.
/// </summary>
public class AwsSignerSigningJobDataSource : TerraformDataSource
{
    public AwsSignerSigningJobDataSource(string name) : base("aws_signer_signing_job", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("completed_at");
        this.DeclareOutput("created_at");
        this.DeclareOutput("job_invoker");
        this.DeclareOutput("job_owner");
        this.DeclareOutput("platform_display_name");
        this.DeclareOutput("platform_id");
        this.DeclareOutput("profile_name");
        this.DeclareOutput("profile_version");
        this.DeclareOutput("requested_by");
        this.DeclareOutput("revocation_record");
        this.DeclareOutput("signature_expires_at");
        this.DeclareOutput("signed_object");
        this.DeclareOutput("source");
        this.DeclareOutput("status");
        this.DeclareOutput("status_reason");
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
    /// The job_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobId is required")]
    public required TerraformProperty<string> JobId
    {
        get => GetProperty<TerraformProperty<string>>("job_id");
        set => this.WithProperty("job_id", value);
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
    /// The completed_at attribute.
    /// </summary>
    public TerraformExpression CompletedAt => this["completed_at"];

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

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
    /// The profile_name attribute.
    /// </summary>
    public TerraformExpression ProfileName => this["profile_name"];

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
    /// The source attribute.
    /// </summary>
    public TerraformExpression Source => this["source"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The status_reason attribute.
    /// </summary>
    public TerraformExpression StatusReason => this["status_reason"];

}
