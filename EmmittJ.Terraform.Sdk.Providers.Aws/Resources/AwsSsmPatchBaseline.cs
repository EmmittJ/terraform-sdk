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
    public HashSet<string>? ApprovedPatches
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("approved_patches")?.Value;
        set => this.WithProperty("approved_patches", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The approved_patches_compliance_level attribute.
    /// </summary>
    public string? ApprovedPatchesComplianceLevel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("approved_patches_compliance_level")?.Value;
        set => this.WithProperty("approved_patches_compliance_level", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The approved_patches_enable_non_security attribute.
    /// </summary>
    public bool? ApprovedPatchesEnableNonSecurity
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("approved_patches_enable_non_security")?.Value;
        set => this.WithProperty("approved_patches_enable_non_security", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The rejected_patches attribute.
    /// </summary>
    public HashSet<string>? RejectedPatches
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("rejected_patches")?.Value;
        set => this.WithProperty("rejected_patches", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The rejected_patches_action attribute.
    /// </summary>
    public string? RejectedPatchesAction
    {
        get => GetProperty<TerraformLiteralProperty<string>>("rejected_patches_action")?.Value;
        set => this.WithProperty("rejected_patches_action", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
