using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for approval_rule in .
/// Nesting mode: list
/// </summary>
public class AwsSsmPatchBaselineApprovalRuleBlock : TerraformBlock
{
    /// <summary>
    /// The approve_after_days attribute.
    /// </summary>
    public TerraformProperty<double>? ApproveAfterDays
    {
        get => GetProperty<TerraformProperty<double>>("approve_after_days");
        set => WithProperty("approve_after_days", value);
    }

    /// <summary>
    /// The approve_until_date attribute.
    /// </summary>
    public TerraformProperty<string>? ApproveUntilDate
    {
        get => GetProperty<TerraformProperty<string>>("approve_until_date");
        set => WithProperty("approve_until_date", value);
    }

    /// <summary>
    /// The compliance_level attribute.
    /// </summary>
    public TerraformProperty<string>? ComplianceLevel
    {
        get => GetProperty<TerraformProperty<string>>("compliance_level");
        set => WithProperty("compliance_level", value);
    }

    /// <summary>
    /// The enable_non_security attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableNonSecurity
    {
        get => GetProperty<TerraformProperty<bool>>("enable_non_security");
        set => WithProperty("enable_non_security", value);
    }

}

/// <summary>
/// Block type for global_filter in .
/// Nesting mode: list
/// </summary>
public class AwsSsmPatchBaselineGlobalFilterBlock : TerraformBlock
{
    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformProperty<string> Key
    {
        get => GetProperty<TerraformProperty<string>>("key");
        set => WithProperty("key", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    public List<TerraformProperty<string>>? Values
    {
        get => GetProperty<List<TerraformProperty<string>>>("values");
        set => WithProperty("values", value);
    }

}

/// <summary>
/// Block type for source in .
/// Nesting mode: list
/// </summary>
public class AwsSsmPatchBaselineSourceBlock : TerraformBlock
{
    /// <summary>
    /// The configuration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Configuration is required")]
    public required TerraformProperty<string> Configuration
    {
        get => GetProperty<TerraformProperty<string>>("configuration");
        set => WithProperty("configuration", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The products attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Products is required")]
    public List<TerraformProperty<string>>? Products
    {
        get => GetProperty<List<TerraformProperty<string>>>("products");
        set => WithProperty("products", value);
    }

}

/// <summary>
/// Manages a aws_ssm_patch_baseline resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
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
    public HashSet<TerraformProperty<string>>? ApprovedPatches
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("approved_patches");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
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
    public HashSet<TerraformProperty<string>>? RejectedPatches
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("rejected_patches");
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
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for approval_rule.
    /// Nesting mode: list
    /// </summary>
    public List<AwsSsmPatchBaselineApprovalRuleBlock>? ApprovalRule
    {
        get => GetProperty<List<AwsSsmPatchBaselineApprovalRuleBlock>>("approval_rule");
        set => this.WithProperty("approval_rule", value);
    }

    /// <summary>
    /// Block for global_filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(4, ErrorMessage = "Maximum 4 GlobalFilter block(s) allowed")]
    public List<AwsSsmPatchBaselineGlobalFilterBlock>? GlobalFilter
    {
        get => GetProperty<List<AwsSsmPatchBaselineGlobalFilterBlock>>("global_filter");
        set => this.WithProperty("global_filter", value);
    }

    /// <summary>
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 Source block(s) allowed")]
    public List<AwsSsmPatchBaselineSourceBlock>? Source
    {
        get => GetProperty<List<AwsSsmPatchBaselineSourceBlock>>("source");
        set => this.WithProperty("source", value);
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
