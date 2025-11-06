using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ssm_patch_baseline.
/// </summary>
public class AwsSsmPatchBaselineDataSource : TerraformDataSource
{
    public AwsSsmPatchBaselineDataSource(string name) : base("aws_ssm_patch_baseline", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("approval_rule");
        this.DeclareOutput("approved_patches");
        this.DeclareOutput("approved_patches_compliance_level");
        this.DeclareOutput("approved_patches_enable_non_security");
        this.DeclareOutput("available_security_updates_compliance_status");
        this.DeclareOutput("description");
        this.DeclareOutput("global_filter");
        this.DeclareOutput("json");
        this.DeclareOutput("name");
        this.DeclareOutput("rejected_patches");
        this.DeclareOutput("rejected_patches_action");
        this.DeclareOutput("source");
    }

    /// <summary>
    /// The default_baseline attribute.
    /// </summary>
    public bool? DefaultBaseline
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("default_baseline")?.Value;
        set => this.WithProperty("default_baseline", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The name_prefix attribute.
    /// </summary>
    public string? NamePrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name_prefix")?.Value;
        set => this.WithProperty("name_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The operating_system attribute.
    /// </summary>
    public string? OperatingSystem
    {
        get => GetProperty<TerraformLiteralProperty<string>>("operating_system")?.Value;
        set => this.WithProperty("operating_system", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    public string? Owner
    {
        get => GetProperty<TerraformLiteralProperty<string>>("owner")?.Value;
        set => this.WithProperty("owner", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The approval_rule attribute.
    /// </summary>
    public TerraformExpression ApprovalRule => this["approval_rule"];

    /// <summary>
    /// The approved_patches attribute.
    /// </summary>
    public TerraformExpression ApprovedPatches => this["approved_patches"];

    /// <summary>
    /// The approved_patches_compliance_level attribute.
    /// </summary>
    public TerraformExpression ApprovedPatchesComplianceLevel => this["approved_patches_compliance_level"];

    /// <summary>
    /// The approved_patches_enable_non_security attribute.
    /// </summary>
    public TerraformExpression ApprovedPatchesEnableNonSecurity => this["approved_patches_enable_non_security"];

    /// <summary>
    /// The available_security_updates_compliance_status attribute.
    /// </summary>
    public TerraformExpression AvailableSecurityUpdatesComplianceStatus => this["available_security_updates_compliance_status"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The global_filter attribute.
    /// </summary>
    public TerraformExpression GlobalFilter => this["global_filter"];

    /// <summary>
    /// The json attribute.
    /// </summary>
    public TerraformExpression Json => this["json"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The rejected_patches attribute.
    /// </summary>
    public TerraformExpression RejectedPatches => this["rejected_patches"];

    /// <summary>
    /// The rejected_patches_action attribute.
    /// </summary>
    public TerraformExpression RejectedPatchesAction => this["rejected_patches_action"];

    /// <summary>
    /// The source attribute.
    /// </summary>
    public TerraformExpression Source => this["source"];

}
