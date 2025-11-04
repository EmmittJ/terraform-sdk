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
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The domain_identifier attribute.
    /// </summary>
    public string? DomainIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_identifier")?.Value;
        set => this.WithProperty("domain_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The owning_project_identifier attribute.
    /// </summary>
    public string? OwningProjectIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("owning_project_identifier")?.Value;
        set => this.WithProperty("owning_project_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public string? Status
    {
        get => GetProperty<TerraformLiteralProperty<string>>("status")?.Value;
        set => this.WithProperty("status", value == null ? null : new TerraformLiteralProperty<string>(value));
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
