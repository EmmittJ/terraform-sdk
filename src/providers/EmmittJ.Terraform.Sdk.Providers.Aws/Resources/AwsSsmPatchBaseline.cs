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
        set => SetProperty("approve_after_days", value);
    }

    /// <summary>
    /// The approve_until_date attribute.
    /// </summary>
    public TerraformProperty<string>? ApproveUntilDate
    {
        set => SetProperty("approve_until_date", value);
    }

    /// <summary>
    /// The compliance_level attribute.
    /// </summary>
    public TerraformProperty<string>? ComplianceLevel
    {
        set => SetProperty("compliance_level", value);
    }

    /// <summary>
    /// The enable_non_security attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableNonSecurity
    {
        set => SetProperty("enable_non_security", value);
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
        set => SetProperty("key", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    public List<TerraformProperty<string>>? Values
    {
        set => SetProperty("values", value);
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
        set => SetProperty("configuration", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The products attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Products is required")]
    public List<TerraformProperty<string>>? Products
    {
        set => SetProperty("products", value);
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
        SetOutput("arn");
        SetOutput("json");
        SetOutput("approved_patches");
        SetOutput("approved_patches_compliance_level");
        SetOutput("approved_patches_enable_non_security");
        SetOutput("available_security_updates_compliance_status");
        SetOutput("description");
        SetOutput("id");
        SetOutput("name");
        SetOutput("operating_system");
        SetOutput("region");
        SetOutput("rejected_patches");
        SetOutput("rejected_patches_action");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The approved_patches attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> ApprovedPatches
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("approved_patches");
        set => SetProperty("approved_patches", value);
    }

    /// <summary>
    /// The approved_patches_compliance_level attribute.
    /// </summary>
    public TerraformProperty<string> ApprovedPatchesComplianceLevel
    {
        get => GetRequiredOutput<TerraformProperty<string>>("approved_patches_compliance_level");
        set => SetProperty("approved_patches_compliance_level", value);
    }

    /// <summary>
    /// The approved_patches_enable_non_security attribute.
    /// </summary>
    public TerraformProperty<bool> ApprovedPatchesEnableNonSecurity
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("approved_patches_enable_non_security");
        set => SetProperty("approved_patches_enable_non_security", value);
    }

    /// <summary>
    /// The available_security_updates_compliance_status attribute.
    /// </summary>
    public TerraformProperty<string> AvailableSecurityUpdatesComplianceStatus
    {
        get => GetRequiredOutput<TerraformProperty<string>>("available_security_updates_compliance_status");
        set => SetProperty("available_security_updates_compliance_status", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The operating_system attribute.
    /// </summary>
    public TerraformProperty<string> OperatingSystem
    {
        get => GetRequiredOutput<TerraformProperty<string>>("operating_system");
        set => SetProperty("operating_system", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The rejected_patches attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> RejectedPatches
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("rejected_patches");
        set => SetProperty("rejected_patches", value);
    }

    /// <summary>
    /// The rejected_patches_action attribute.
    /// </summary>
    public TerraformProperty<string> RejectedPatchesAction
    {
        get => GetRequiredOutput<TerraformProperty<string>>("rejected_patches_action");
        set => SetProperty("rejected_patches_action", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for approval_rule.
    /// Nesting mode: list
    /// </summary>
    public List<AwsSsmPatchBaselineApprovalRuleBlock>? ApprovalRule
    {
        set => SetProperty("approval_rule", value);
    }

    /// <summary>
    /// Block for global_filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(4, ErrorMessage = "Maximum 4 GlobalFilter block(s) allowed")]
    public List<AwsSsmPatchBaselineGlobalFilterBlock>? GlobalFilter
    {
        set => SetProperty("global_filter", value);
    }

    /// <summary>
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 Source block(s) allowed")]
    public List<AwsSsmPatchBaselineSourceBlock>? Source
    {
        set => SetProperty("source", value);
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
