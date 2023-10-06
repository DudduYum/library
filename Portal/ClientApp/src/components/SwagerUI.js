import React, { useEffect, useState } from 'react';

function SwaggerUI() {
  const [swaggerHtml, setSwaggerHtml] = useState('');

  useEffect(() => {
    async function fetchSwagger() {
      try {
        const response = await fetch('http://localhost:44441/swagger'); // Replace PORT with your API's port
        const html = await response.text();
        setSwaggerHtml(html);
      } catch (error) {
        console.error('Error fetching Swagger UI:', error);
      }
    }

    fetchSwagger();
  }, []);

  return <div dangerouslySetInnerHTML={{ __html: swaggerHtml }} />;
}

export default SwaggerUI;
