using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_securityhub_standards_control_association resource.
/// </summary>
public class AwsSecurityhubStandardsControlAssociation : TerraformResource
{
    public AwsSecurityhubStandardsControlAssociation(string name) : base("aws_securityhub_standards_control_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("id");
    }

    /// <summary>
    /// The association_status attribute.
    /// </summary>
    public string? AssociationStatus
    {
        get => GetProperty<TerraformLiteralProperty<string>>("association_status")?.Value;
        set => this.WithProperty("association_status", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The security_control_id attribute.
    /// </summary>
    public string? SecurityControlId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("security_control_id")?.Value;
        set => this.WithProperty("security_control_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The standards_arn attribute.
    /// </summary>
    public string? StandardsArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("standards_arn")?.Value;
        set => this.WithProperty("standards_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The updated_reason attribute.
    /// </summary>
    public string? UpdatedReason
    {
        get => GetProperty<TerraformLiteralProperty<string>>("updated_reason")?.Value;
        set => this.WithProperty("updated_reason", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
