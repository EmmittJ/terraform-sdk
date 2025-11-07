using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_datazone_form_type resource.
/// </summary>
public class AwsDatazoneFormType : TerraformResource
{
    public AwsDatazoneFormType(string name) : base("aws_datazone_form_type", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("created_at");
        this.DeclareOutput("created_by");
        this.DeclareOutput("imports");
        this.DeclareOutput("origin_domain_id");
        this.DeclareOutput("origin_project_id");
        this.DeclareOutput("revision");
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
    /// The domain_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? DomainIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("domain_identifier");
        set => this.WithProperty("domain_identifier", value);
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
    /// The owning_project_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? OwningProjectIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("owning_project_identifier");
        set => this.WithProperty("owning_project_identifier", value);
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
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        get => GetProperty<TerraformProperty<string>>("status");
        set => this.WithProperty("status", value);
    }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The created_by attribute.
    /// </summary>
    public TerraformExpression CreatedBy => this["created_by"];

    /// <summary>
    /// The imports attribute.
    /// </summary>
    public TerraformExpression Imports => this["imports"];

    /// <summary>
    /// The origin_domain_id attribute.
    /// </summary>
    public TerraformExpression OriginDomainId => this["origin_domain_id"];

    /// <summary>
    /// The origin_project_id attribute.
    /// </summary>
    public TerraformExpression OriginProjectId => this["origin_project_id"];

    /// <summary>
    /// The revision attribute.
    /// </summary>
    public TerraformExpression Revision => this["revision"];

}
