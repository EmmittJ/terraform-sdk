using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ssm_patch_baseline resource.
/// </summary>
public class AwsSsmPatchBaseline : TerraformResource
{
    public AwsSsmPatchBaseline(string name) : base("aws_ssm_patch_baseline", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("json");
    }

    /// <summary>
    /// The approved_patches attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? ApprovedPatches
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("approved_patches");
        set => this.WithProperty("approved_patches", value);
    }

    /// <summary>
    /// The approved_patches_compliance_level attribute.
    /// </summary>
    public TerraformProperty<string>? ApprovedPatchesComplianceLevel
    {
        get => GetProperty<TerraformProperty<string>>("approved_patches_compliance_level");
        set => this.WithProperty("approved_patches_compliance_level", value);
    }

    /// <summary>
    /// The approved_patches_enable_non_security attribute.
    /// </summary>
    public TerraformProperty<bool>? ApprovedPatchesEnableNonSecurity
    {
        get => GetProperty<TerraformProperty<bool>>("approved_patches_enable_non_security");
        set => this.WithProperty("approved_patches_enable_non_security", value);
    }

    /// <summary>
    /// The available_security_updates_compliance_status attribute.
    /// </summary>
    public TerraformProperty<string>? AvailableSecurityUpdatesComplianceStatus
    {
        get => GetProperty<TerraformProperty<string>>("available_security_updates_compliance_status");
        set => this.WithProperty("available_security_updates_compliance_status", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The rejected_patches attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? RejectedPatches
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("rejected_patches");
        set => this.WithProperty("rejected_patches", value);
    }

    /// <summary>
    /// The rejected_patches_action attribute.
    /// </summary>
    public TerraformProperty<string>? RejectedPatchesAction
    {
        get => GetProperty<TerraformProperty<string>>("rejected_patches_action");
        set => this.WithProperty("rejected_patches_action", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The json attribute.
    /// </summary>
    public TerraformExpression Json => this["json"];

}
