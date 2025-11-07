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
    public TerraformLiteralProperty<HashSet<string>>? ApprovedPatches
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("approved_patches");
        set => this.WithProperty("approved_patches", value);
    }

    /// <summary>
    /// The approved_patches_compliance_level attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ApprovedPatchesComplianceLevel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("approved_patches_compliance_level");
        set => this.WithProperty("approved_patches_compliance_level", value);
    }

    /// <summary>
    /// The approved_patches_enable_non_security attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ApprovedPatchesEnableNonSecurity
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("approved_patches_enable_non_security");
        set => this.WithProperty("approved_patches_enable_non_security", value);
    }

    /// <summary>
    /// The available_security_updates_compliance_status attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AvailableSecurityUpdatesComplianceStatus
    {
        get => GetProperty<TerraformLiteralProperty<string>>("available_security_updates_compliance_status");
        set => this.WithProperty("available_security_updates_compliance_status", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The operating_system attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? OperatingSystem
    {
        get => GetProperty<TerraformLiteralProperty<string>>("operating_system");
        set => this.WithProperty("operating_system", value);
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
    /// The rejected_patches attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? RejectedPatches
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("rejected_patches");
        set => this.WithProperty("rejected_patches", value);
    }

    /// <summary>
    /// The rejected_patches_action attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RejectedPatchesAction
    {
        get => GetProperty<TerraformLiteralProperty<string>>("rejected_patches_action");
        set => this.WithProperty("rejected_patches_action", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
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
