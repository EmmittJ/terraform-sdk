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
        this.WithOutput("approval_rule");
        this.WithOutput("approved_patches");
        this.WithOutput("approved_patches_compliance_level");
        this.WithOutput("approved_patches_enable_non_security");
        this.WithOutput("available_security_updates_compliance_status");
        this.WithOutput("description");
        this.WithOutput("global_filter");
        this.WithOutput("json");
        this.WithOutput("name");
        this.WithOutput("rejected_patches");
        this.WithOutput("rejected_patches_action");
        this.WithOutput("source");
    }

    /// <summary>
    /// The default_baseline attribute.
    /// </summary>
    public TerraformProperty<bool>? DefaultBaseline
    {
        get => GetProperty<TerraformProperty<bool>>("default_baseline");
        set => this.WithProperty("default_baseline", value);
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
    /// The name_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? NamePrefix
    {
        get => GetProperty<TerraformProperty<string>>("name_prefix");
        set => this.WithProperty("name_prefix", value);
    }

    /// <summary>
    /// The operating_system attribute.
    /// </summary>
    public TerraformProperty<string>? OperatingSystem
    {
        get => GetProperty<TerraformProperty<string>>("operating_system");
        set => this.WithProperty("operating_system", value);
    }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Owner is required")]
    public required TerraformProperty<string> Owner
    {
        get => GetRequiredProperty<TerraformProperty<string>>("owner");
        set => this.WithProperty("owner", value);
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
