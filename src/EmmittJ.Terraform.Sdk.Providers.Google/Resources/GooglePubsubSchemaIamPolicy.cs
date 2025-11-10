using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_pubsub_schema_iam_policy resource.
/// </summary>
public class GooglePubsubSchemaIamPolicy : TerraformResource
{
    public GooglePubsubSchemaIamPolicy(string name) : base("google_pubsub_schema_iam_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("etag");
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
    /// The policy_data attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyData is required")]
    public required TerraformProperty<string> PolicyData
    {
        get => GetProperty<TerraformProperty<string>>("policy_data");
        set => this.WithProperty("policy_data", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The schema attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schema is required")]
    public required TerraformProperty<string> Schema
    {
        get => GetProperty<TerraformProperty<string>>("schema");
        set => this.WithProperty("schema", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

}
