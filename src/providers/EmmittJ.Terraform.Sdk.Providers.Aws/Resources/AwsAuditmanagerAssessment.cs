using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for assessment_reports_destination in AwsAuditmanagerAssessment.
/// Nesting mode: list
/// </summary>
public class AwsAuditmanagerAssessmentAssessmentReportsDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "assessment_reports_destination";

    /// <summary>
    /// The destination attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    public required TerraformValue<string> Destination
    {
        get => new TerraformReference<string>(this, "destination");
        set => SetArgument("destination", value);
    }

    /// <summary>
    /// The destination_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationType is required")]
    public required TerraformValue<string> DestinationType
    {
        get => new TerraformReference<string>(this, "destination_type");
        set => SetArgument("destination_type", value);
    }

}


/// <summary>
/// Block type for roles in AwsAuditmanagerAssessment.
/// Nesting mode: set
/// </summary>
public class AwsAuditmanagerAssessmentRolesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "roles";

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The role_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleType is required")]
    public required TerraformValue<string> RoleType
    {
        get => new TerraformReference<string>(this, "role_type");
        set => SetArgument("role_type", value);
    }

}


/// <summary>
/// Block type for scope in AwsAuditmanagerAssessment.
/// Nesting mode: list
/// </summary>
public class AwsAuditmanagerAssessmentScopeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scope";

    /// <summary>
    /// AwsAccounts block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsAuditmanagerAssessmentScopeBlockAwsAccountsBlock>? AwsAccounts
    {
        get => GetArgument<TerraformSet<AwsAuditmanagerAssessmentScopeBlockAwsAccountsBlock>>("aws_accounts");
        set => SetArgument("aws_accounts", value);
    }

    /// <summary>
    /// AwsServices block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsAuditmanagerAssessmentScopeBlockAwsServicesBlock>? AwsServices
    {
        get => GetArgument<TerraformSet<AwsAuditmanagerAssessmentScopeBlockAwsServicesBlock>>("aws_services");
        set => SetArgument("aws_services", value);
    }

}

/// <summary>
/// Block type for aws_accounts in AwsAuditmanagerAssessmentScopeBlock.
/// Nesting mode: set
/// </summary>
public class AwsAuditmanagerAssessmentScopeBlockAwsAccountsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "aws_accounts";

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

}

/// <summary>
/// Block type for aws_services in AwsAuditmanagerAssessmentScopeBlock.
/// Nesting mode: set
/// </summary>
public class AwsAuditmanagerAssessmentScopeBlockAwsServicesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "aws_services";

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    public required TerraformValue<string> ServiceName
    {
        get => new TerraformReference<string>(this, "service_name");
        set => SetArgument("service_name", value);
    }

}


/// <summary>
/// Represents a aws_auditmanager_assessment Terraform resource.
/// Manages a aws_auditmanager_assessment resource.
/// </summary>
public partial class AwsAuditmanagerAssessment(string name) : TerraformResource("aws_auditmanager_assessment", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The framework_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrameworkId is required")]
    public required TerraformValue<string> FrameworkId
    {
        get => new TerraformReference<string>(this, "framework_id");
        set => SetArgument("framework_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The roles_all attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RolesAll
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "roles_all").ResolveNodes(ctx));
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
    }

    /// <summary>
    /// AssessmentReportsDestination block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsAuditmanagerAssessmentAssessmentReportsDestinationBlock>? AssessmentReportsDestination
    {
        get => GetArgument<TerraformList<AwsAuditmanagerAssessmentAssessmentReportsDestinationBlock>>("assessment_reports_destination");
        set => SetArgument("assessment_reports_destination", value);
    }

    /// <summary>
    /// Roles block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsAuditmanagerAssessmentRolesBlock>? Roles
    {
        get => GetArgument<TerraformSet<AwsAuditmanagerAssessmentRolesBlock>>("roles");
        set => SetArgument("roles", value);
    }

    /// <summary>
    /// Scope block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsAuditmanagerAssessmentScopeBlock>? Scope
    {
        get => GetArgument<TerraformList<AwsAuditmanagerAssessmentScopeBlock>>("scope");
        set => SetArgument("scope", value);
    }

}
