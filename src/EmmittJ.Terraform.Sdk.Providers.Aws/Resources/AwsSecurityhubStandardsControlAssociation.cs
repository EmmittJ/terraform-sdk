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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssociationStatus is required")]
    public required TerraformProperty<string> AssociationStatus
    {
        get => GetProperty<TerraformProperty<string>>("association_status");
        set => this.WithProperty("association_status", value);
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
    /// The security_control_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityControlId is required")]
    public required TerraformProperty<string> SecurityControlId
    {
        get => GetProperty<TerraformProperty<string>>("security_control_id");
        set => this.WithProperty("security_control_id", value);
    }

    /// <summary>
    /// The standards_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StandardsArn is required")]
    public required TerraformProperty<string> StandardsArn
    {
        get => GetProperty<TerraformProperty<string>>("standards_arn");
        set => this.WithProperty("standards_arn", value);
    }

    /// <summary>
    /// The updated_reason attribute.
    /// </summary>
    public TerraformProperty<string>? UpdatedReason
    {
        get => GetProperty<TerraformProperty<string>>("updated_reason");
        set => this.WithProperty("updated_reason", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
