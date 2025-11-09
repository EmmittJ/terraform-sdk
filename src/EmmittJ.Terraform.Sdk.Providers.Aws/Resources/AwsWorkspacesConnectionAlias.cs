using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_workspaces_connection_alias resource.
/// </summary>
public class AwsWorkspacesConnectionAlias : TerraformResource
{
    public AwsWorkspacesConnectionAlias(string name) : base("aws_workspaces_connection_alias", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("id");
        this.DeclareOutput("owner_account_id");
        this.DeclareOutput("state");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// The connection string specified for the connection alias. The connection string must be in the form of a fully qualified domain name (FQDN), such as www.example.com.
    /// </summary>
    public TerraformProperty<string>? ConnectionString
    {
        get => GetProperty<TerraformProperty<string>>("connection_string");
        set => this.WithProperty("connection_string", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The identifier of the Amazon Web Services account that owns the connection alias.
    /// </summary>
    public TerraformExpression OwnerAccountId => this["owner_account_id"];

    /// <summary>
    /// The current state of the connection alias.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
