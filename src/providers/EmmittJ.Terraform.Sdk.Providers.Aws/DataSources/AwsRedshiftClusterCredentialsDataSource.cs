using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_redshift_cluster_credentials Terraform data source.
/// Retrieves information about a aws_redshift_cluster_credentials.
/// </summary>
public partial class AwsRedshiftClusterCredentialsDataSource(string name) : TerraformDataSource("aws_redshift_cluster_credentials", name)
{
    /// <summary>
    /// The auto_create attribute.
    /// </summary>
    public TerraformValue<bool>? AutoCreate
    {
        get => GetArgument<TerraformValue<bool>>("auto_create");
        set => SetArgument("auto_create", value);
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIdentifier is required")]
    public required TerraformValue<string> ClusterIdentifier
    {
        get => GetRequiredArgument<TerraformValue<string>>("cluster_identifier");
        set => SetArgument("cluster_identifier", value);
    }

    /// <summary>
    /// The db_groups attribute.
    /// </summary>
    public TerraformSet<string>? DbGroups
    {
        get => GetArgument<TerraformSet<string>>("db_groups");
        set => SetArgument("db_groups", value);
    }

    /// <summary>
    /// The db_name attribute.
    /// </summary>
    public TerraformValue<string>? DbName
    {
        get => GetArgument<TerraformValue<string>>("db_name");
        set => SetArgument("db_name", value);
    }

    /// <summary>
    /// The db_user attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbUser is required")]
    public required TerraformValue<string> DbUser
    {
        get => GetRequiredArgument<TerraformValue<string>>("db_user");
        set => SetArgument("db_user", value);
    }

    /// <summary>
    /// The duration_seconds attribute.
    /// </summary>
    public TerraformValue<double>? DurationSeconds
    {
        get => GetArgument<TerraformValue<double>>("duration_seconds");
        set => SetArgument("duration_seconds", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The db_password attribute.
    /// </summary>
    public TerraformValue<string> DbPassword
        => AsReference("db_password");

    /// <summary>
    /// The expiration attribute.
    /// </summary>
    public TerraformValue<string> Expiration
        => AsReference("expiration");

}
